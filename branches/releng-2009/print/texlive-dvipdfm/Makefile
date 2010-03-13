# New ports collection makefile for:	texlive-dvipdfm
# Date created:		13/03/2010 04:19:29
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dvipdfm
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A DVI driver to produce PDF directly.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
