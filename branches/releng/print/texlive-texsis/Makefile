# New ports collection makefile for:	texlive-texsis
# Date created:		26/01/2009 16:04:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texsis
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Plain TeX macros for Physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.texsis.cnf:${PORTSDIR}/print/texlive-bin-texsis

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
