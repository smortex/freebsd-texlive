# New ports collection makefile for:	texlive-ps2pkm
# Date created:		13/03/2010 04:30:35
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	ps2pkm
PORTVERSION=	20120529
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate a PK font from an Adobe Type 1 font.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
