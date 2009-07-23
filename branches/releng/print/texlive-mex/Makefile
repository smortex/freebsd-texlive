# New ports collection makefile for:	texlive-mex
# Date created:		26/01/2009 16:06:34
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	mex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Polish formats for TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/pl/config.pl:${PORTSDIR}/print/texlive-pl \
		${LOCALBASE}/share/texmf/fmtutil/format.mex.cnf:${PORTSDIR}/print/texlive-bin-mex

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
