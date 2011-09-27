# New ports collection makefile for:	texlive-xetex
# Date created:		13/03/2010 04:22:29
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	xetex
PORTVERSION=	20110927
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Unicode and OpenType-enabled TeX engine.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xetexconfig/unicode-letters.tex:${PORTSDIR}/print/texlive-xetexconfig \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
