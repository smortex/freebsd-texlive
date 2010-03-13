# New ports collection makefile for:	texlive-xetex
# Date created:		13/03/2010 04:22:29
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	xetex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The xetex package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xetexconfig/unicode-letters.tex:${PORTSDIR}/print/texlive-xetexconfig \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
