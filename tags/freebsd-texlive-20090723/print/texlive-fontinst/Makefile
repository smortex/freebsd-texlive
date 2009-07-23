# New ports collection makefile for:	texlive-fontinst
# Date created:		26/01/2009 16:03:55
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	fontinst
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Help with installing fonts for TeX and LaTeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
