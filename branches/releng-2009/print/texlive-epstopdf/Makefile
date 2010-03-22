# New ports collection makefile for:	texlive-epstopdf
# Date created:		13/03/2010 04:30:32
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	epstopdf
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Convert EPS to 'encapsulated' PDF using GhostScript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
