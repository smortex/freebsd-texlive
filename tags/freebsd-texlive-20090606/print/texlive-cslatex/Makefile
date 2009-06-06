# New ports collection makefile for:	texlive-cslatex
# Date created:		26/01/2009 16:06:01
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	cslatex
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	LaTeX support for Czech/Slovak typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.cslatex.cnf:${PORTSDIR}/print/texlive-bin-cslatex

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
